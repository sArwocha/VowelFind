//# VowelFind
//find vowel from String
using system;
namespace myprogram{
class vwl{
public static void Main(string[] args){
Console.WriteLine("Enter The string");
string str=Console.Readline();
string new="";
str=str.ToLower();
for(int i=0;i<str.length;i++){
if (str[i]='a'|| str[i]='e'|| str[i]='i'|| str[i]='o'|| str[i]='u'||){
new+=str[i];
}
}
Console.WriteLine("The vowels are ::");
Console.WriteLine(new);
Console.ReadLine();
}
}
}
