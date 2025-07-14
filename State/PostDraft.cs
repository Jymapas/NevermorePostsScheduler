namespace NevermorePostsScheduler.State;

internal class PostDraft
{
    internal long AdminId { get; set; }
    internal int MessageId { get; set; }
    internal string ChannelName { get; set; }
    internal DateTime ScheduledTime { get; set; }
}