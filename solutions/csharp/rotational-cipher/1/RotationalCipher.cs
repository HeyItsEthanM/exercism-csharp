using System;
using System.Text;
public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey){
        StringBuilder sb = new StringBuilder();
        string letters = "abcdefghijklmnopqrstuvwxyz";
        foreach(char letter in text){
            if (letter == ' ' || char.IsNumber(letter) || char.IsPunctuation(letter)){
                sb.Append(letter);
                continue;
            }
            int index = (letters.IndexOf(char.ToLower(letter)) + shiftKey) % 26;
            if (char.IsUpper(letter)){
                sb.Append(char.ToUpper(letters[index]));
                continue;
        }
            sb.Append(letters[index]);
        }
        string cleaned = sb.ToString();
        return cleaned;
    }

}
