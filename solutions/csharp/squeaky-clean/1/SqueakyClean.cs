using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder(identifier);
        sb.Replace(" ", "_");
        for(int i=0; i< sb.Length; i++){
            if (i > sb.Length){
                break;
            }
            else if (char.IsControl(sb[i])){
                sb.Remove(i,1);
                sb.Insert(i,"CTRL");
            }
        }
        for (int i=0; i< sb.Length ; i++){
            if(sb[i] == '-'){
                sb.Remove(i,1);
                sb[i] = Char.ToUpper(sb[i]);
                i -=1;
            }
        }
        for (int i=0; i< sb.Length; i++){
            if(!(Char.IsLetter(sb[i]))){
                if(sb[i] == '_'){
                    continue;
                }
                sb.Remove(i,1);
                i-=1;
            }
        }

        for (int i=0; i<sb.Length; i++){
            if(sb[i] >= 'α' && sb[i] <= 'ω' ){
            sb.Remove(i,1);
                i-=1;
            }
        }
        
        string cleaned = sb.ToString();
        return cleaned;
    }
}
