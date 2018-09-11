﻿using System;
using System.Threading.Tasks;
using Telegram.Bot.Abstractions;
using Telegram.Bot.Types;

namespace Quickstart.Net45.Handlers
{
    public class TextEchoer : IUpdateHandler
    {
        public async Task HandleAsync(IBot bot, IUpdateContext context, UpdateDelegate next)
        {
            Message msg = context.Update.Message;

            await bot.Client.SendTextMessageAsync(
                msg.Chat, "You said:\n" + msg.Text
            );

            await next(context);

            throw new Exception("########### RANDOM EXCEPTION ###########");
        }
    }
}