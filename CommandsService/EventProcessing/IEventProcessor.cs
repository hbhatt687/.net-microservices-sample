namespace CommandsService.EventsProcessing
{
    public interface IEventProcessor
    {
        void ProcessEvent(string message);
    }
}