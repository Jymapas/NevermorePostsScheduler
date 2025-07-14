namespace NevermorePostsScheduler.State;

internal enum PostState
{
    None,
    WaitingForMessage,
    WaitingForChannel,
    WaitingForDateTime,
    Confirm
}