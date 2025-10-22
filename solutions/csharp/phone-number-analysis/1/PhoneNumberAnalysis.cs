public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string areaCode = phoneNumber.Substring(0,3);
        string prefix = phoneNumber.Substring(4,3);
        string LocalNumber = phoneNumber.Substring(8,4);
        bool IsNewYork = (areaCode == "212");
        bool IsFake = (prefix == "555");
            return (IsNewYork, IsFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
