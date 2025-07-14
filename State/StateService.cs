namespace NevermorePostsScheduler.State;

internal class StateService
{
    private readonly Dictionary<long, PostDraft> _drafts = new();
    private readonly Dictionary<long, PostState> _states = new();

    public PostState GetState(long adminId)
    {
        return _states.GetValueOrDefault(adminId, PostState.None);
    }

    public void SetState(long adminId, PostState postState)
    {
        _states[adminId] = postState;
    }

    public PostDraft? GetDraft(long adminId)
    {
        return _drafts.GetValueOrDefault(adminId);
    }

    public void SetDraft(long adminId, PostDraft postDraft)
    {
        _drafts[adminId] = postDraft;
    }

    public void Clear(long adminId)
    {
        _states.Remove(adminId);
        _drafts.Remove(adminId);
    }
}