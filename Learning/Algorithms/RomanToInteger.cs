public class RomanToInt {
    public int Solve(string s) {
        s=s.Trim();
        //Edge cases
        if(String.IsNullOrEmpty(s))
            throw new ArgumentException();
        int start = 0;
        int number=0;
        while(start < s.Length){
            switch(s[start++])
            {
                case 'M': number+=1000;break;
                case 'D': number+=500;break;
                case 'C': 
                    if(start < s.Length && (s[start] == 'D' || s[start] == 'M'))
                        number-=100;
                    else
                        number+=100;
                    break;
                case 'L': number+=50;break;
                case 'X': 
                    
                    if(start < s.Length && (s[start] == 'L' || s[start] == 'C'))
                        number-=10;
                    else
                        number+=10;
                    break;
                case 'V': number+=5;break;
                case 'I':
                    if(start < s.Length && (s[start] == 'V' || s[start] == 'X'))
                        number-=1;
                    else
                         number+=1;
                    break;
            }
            
        
    }
        return number;
    }
}
