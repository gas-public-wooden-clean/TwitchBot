﻿using TwitchBot.CommandParsing.Templates;

namespace TwitchBot.Commands
{
    class JoinDrinkingGameCommand : ACommand
    {
		/// <summary>
		/// Join a running drinking game
		/// </summary>
		/// <param name="content"></param>
		/// <param name="from"></param>
		/// <param name="target"></param>
		/// <param name="cb"></param>
        public JoinDrinkingGameCommand( string content, string from, string target, CommandCallback cb ) : base( content, from, target, cb )
        {
        }
    }
}
