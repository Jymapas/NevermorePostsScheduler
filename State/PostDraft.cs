namespace NevermorePostsScheduler.State;

internal class PostDraft
{
    private long AdminId { get; set; }
    private int MessageId { get; set; }
    private string ChannelName { get; set; }
    private DateTime ScheduledTime { get; set; }
}