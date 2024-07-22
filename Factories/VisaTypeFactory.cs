namespace Domain.Factories
{
    public class VisaTypeFactory
    {
        public VisaType Create(string title, string description, int minDuration, int maxDuration)
        {
            // Logic for creating a valid VisaType
            return new VisaType(title, description, minDuration, maxDuration);
        }
    }
}
