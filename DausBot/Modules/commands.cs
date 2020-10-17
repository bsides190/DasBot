using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace DausBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("Ping")]
        public async Task Ping() => await ReplyAsync("Your Internet Blows");
    }
}


