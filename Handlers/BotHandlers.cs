using NevermorePostsScheduler.State;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace NevermorePostsScheduler.Handlers;

internal class BotHandlers
{
    private static readonly long[] AdminIds = [];

    internal async Task HandleCommandAsync(Message message, StateService stateService, ITelegramBotClient botClient)
    {
        if (!AdminIds.Contains(message.From!.Id))
        {
            await botClient.SendMessage(message.Chat.Id, "Доступ запрещён.");
            return;
        }

        if (string.Equals(message.Text?.Trim(), "/new", StringComparison.InvariantCultureIgnoreCase))
        {
            stateService.SetState(message.Chat.Id, PostState.WaitingForMessage);
            stateService.SetDraft(message.From.Id, new PostDraft
            {
                AdminId = message.From.Id
            });

            await botClient.SendMessage(message.Chat.Id, "Пришли сообщение, которое нужно добавить в отложку.");
        }
    }
}