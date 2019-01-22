namespace System.Entities.AuditExtensions
{
    public class AuditChangeModel
    {
        public string ColumnName { get; set; }
        public dynamic OldValue { get; set; }
        public dynamic NewValue { get; set; }
    }
}
