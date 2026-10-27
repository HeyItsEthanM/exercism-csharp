public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string areaCode = phoneNumber[0..3];
        bool ny = false;
        bool fake = false;
        if (areaCode == "212"){
             ny = true;
        }
        string prefixCode = phoneNumber[4..7];
        if (prefixCode == "555"){
             fake = true;
        }
        string lastDigits = phoneNumber[8..];
        return (ny, fake, lastDigits);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.Item2;
}
