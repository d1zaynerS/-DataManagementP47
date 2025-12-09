using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace TextSearchApp
{
    internal class Program
    {
        private static void SetupNLog()
        {
            var config = new LoggingConfiguration();

            var consoleTarget = new ConsoleTarget("console")
            {
                Layout = "${level:uppercase=true}: ${message}"
            };
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, consoleTarget);

            var fileTarget = new FileTarget("file")
            {
                FileName = "app_log.txt",
                Layout = "${longdate} [${level:uppercase=true}] ${message} ${exception:format=tostring}"
            };
            config.AddRule(LogLevel.Info, LogLevel.Fatal, fileTarget);

            LogManager.Configuration = config;
            LogManager.GetCurrentClassLogger().Info("NLog ready.");
        }

        public static List<string> ReadAndSplitToSentences(string filePath, ILogger logger)
        {
            try
            {
                logger.Info($"Reading file: {filePath}");

                string content = File.ReadAllText(filePath);

                var sentences = Regex.Split(content, @"(?<=[\.!\?])\s+(?=[A-ZА-Я])");

                var sentenceList = new List<string>(sentences);
                sentenceList.RemoveAll(string.IsNullOrWhiteSpace);

                logger.Info($"Read {sentenceList.Count} sentences.");
                return sentenceList;
            }
            catch (FileNotFoundException)
            {
                logger.Error($"File not found: {filePath}");
                return new List<string>();
            }
            catch (System.Exception ex)
            {
                logger.Error(ex, $"Unknown error: {ex.Message}");
                return new List<string>();
            }
        }

        public static List<string> FindSentences(List<string> sentences, string pattern, ILogger logger)
        {
            var results = new List<string>();

            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    results.Add(sentence.Trim());
                }
            }
            logger.Info($"Found {results.Count} results for pattern {pattern}.");
            return results;
        }

        static void Main(string[] args)
        {
            SetupNLog();
            var logger = LogManager.GetCurrentClassLogger();

            logger.Info("Program started.");

            string inputFilePath = "input_text.txt";
            if (!File.Exists(inputFilePath))
            {
                File.WriteAllText(inputFilePath, "A. b. 1.");
                logger.Info($"Created test file.");
            }

            List<string> allSentences = ReadAndSplitToSentences(inputFilePath, logger);

            var patterns = new Dictionary<string, string>
            {
                {"Small English Letter", @"[a-z]"},
                {"Digit", @"\d"},
                {"Capital English Letter", @"[A-Z]"}
            };

            Console.WriteLine("--- Search Results ---");

            foreach (var kvp in patterns)
            {
                string description = kvp.Key;
                string pattern = kvp.Value;

                List<string> results = FindSentences(allSentences, pattern, logger);

                Console.WriteLine($"\nPattern: {description} ({pattern})");

                if (results.Count > 0)
                {
                    foreach (var sentence in results)
                    {
                        Console.WriteLine($"> {sentence}");
                    }
                }
                else
                {
                    Console.WriteLine("Not found.");
                }
            }

            logger.Info("Program finished.");
            LogManager.Shutdown();
        }
    }
}