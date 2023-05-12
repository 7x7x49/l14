using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        Regex regIpv6 = new Regex(
            "^([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$|" +
            "^(:(((:([0-9a-fA-F]){1,4}){1,7})|:))$|"+
            "^[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})$|"+
            "^([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}$|"+
            "^([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}$|"+
            "^([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}$|" +
            "^([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}$|" +
            "^([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}$|" +
            "^([0-9a-fA-F]{1,4}:){1,7}:$");

        
        Regex regIpv4 = new Regex("^((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9]?)$");

        string ip = Console.ReadLine();

        do {
            if (ip == "+") { break; }
            Match ipv6 = regIpv6.Match(ip);
            Match ipv4 = regIpv4.Match(ip);

            if (ipv6.Success)
            {
                Console.WriteLine("IPv6: " + ipv6.Value);
            }
            else if (ipv4.Success)
            {
                Console.WriteLine("IPv4: " + ipv4.Value);
            }
            else
            {
                Console.WriteLine("Не нейдено");
            }
            ip = Console.ReadLine();
        }
        while (ip != "+");
    }
}
