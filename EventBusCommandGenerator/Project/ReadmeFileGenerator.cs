﻿using System.Text;

namespace OliveGenerator
{
    internal class ReadmeFileGenerator
    {
        // static string QueueName => Context.EndpointName.Replace(".", "-");

        internal static string Generate()
        {
            var r = new StringBuilder();
            r.AppendLine();

            r.AppendLine($"The {Context.CommandType.FullName} Command package is generated by: Olive Event Bus Command Generator.");
            r.AppendLine("To learn how to use it, visit: https://geeksltd.github.io/Olive/#/Api/EventBusCommands");
            r.AppendLine();
            r.AppendLine();

            r.AppendLine(GenerateQuickReference());

            return r.ToString();
        }

        static string GenerateQuickReference()
        {
            var r = new StringBuilder();

            r.AppendLine("Need information for this part");

            return r.ToString();
        }
    }
}