namespace MediatorDP
{
    public record NotifyMessage(NotifyType NotifyType, string Message, Dictionary<string, object> ExtraData, DateTime CreatedDate);
}
