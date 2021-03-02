﻿using System;
using CommandSystem;

namespace Blackout.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    [CommandHandler(typeof(GameConsoleCommandHandler))]
    public sealed class Blackout : ParentCommand
    {
        public Blackout() => LoadGeneratedCommands();
        
        public override void LoadGeneratedCommands()
        {
            RegisterCommand(new Enable());
            RegisterCommand(new Disable());
        }

        protected override bool ExecuteParent(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response =
                "Please use a valid sub-command.\nEnable - enables the gamemode.\nDisable - disables the gamemode.";
            return false;
        }

        public override string Command { get; } = "blackout";
        public override string[] Aliases { get; } = {};
        public override string Description { get; } = string.Empty;
    }
}