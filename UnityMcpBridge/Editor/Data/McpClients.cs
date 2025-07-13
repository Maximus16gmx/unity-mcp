using System;
using System.Collections.Generic;
using System.IO;
using UnityMcpBridge.Editor.Models;

namespace UnityMcpBridge.Editor.Data
{
    public class McpClients
    {
        public List<McpClient> clients = new()
        {
            new()
            {
                name = "Claude Desktop",
                windowsConfigPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "Claude",
                    "claude_desktop_config.json"
                ),
                linuxConfigPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Library",
                    "Application Support",
                    "Claude",
                    "claude_desktop_config.json"
                ),
                mcpType = McpTypes.ClaudeDesktop,
                configStatus = "Not Configured",
            },
            new()
            {
                name = "Cursor",
                windowsConfigPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    ".cursor",
                    "mcp.json"
                ),
                linuxConfigPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    ".cursor",
                    "mcp.json"
                ),
                mcpType = McpTypes.Cursor,
                configStatus = "Not Configured",
            },
            new()
            {
                name = "Gemini CLI",
                windowsConfigPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    ".gemini",
                    "mcp.json"
                ),
                linuxConfigPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    ".gemini",
                    "mcp.json"
                ),
                mcpType = McpTypes.GeminiCli,
                configStatus = "Not Configured",
            },
            new()
            {
                name = "Claude Code",
                windowsConfigPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "Code",
                    "claude_code_config.json"
                ),
                linuxConfigPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    ".config",
                    "Code",
                    "claude_code_config.json"
                ),
                mcpType = McpTypes.ClaudeCode,
                configStatus = "Not Configured",
            },
            
        };

        // Initialize status enums after construction
        public McpClients()
        {
            foreach (var client in clients)
            {
                if (client.configStatus == "Not Configured")
                {
                    client.status = McpStatus.NotConfigured;
                }
            }
        }
    }
}

