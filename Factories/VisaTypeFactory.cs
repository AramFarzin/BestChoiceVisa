namespace Domain.Factories
{
    internal class VisaTypeFactory
    {
        internal VisaType Create(string title, string description, int minDuration, int maxDuration)
        {
            // check if visaType needs to be created
            // VisaType visaType = await _visaRepository.FindVisaTypeAsync(visaType.Id);
            // if(visaType == null)
            // {
            //     VisaTypeFactory.Create(visaType);
            // }
            // Logic for creating a valid VisaType
            return new VisaType(title, description, minDuration, maxDuration);
        }
    }
}
