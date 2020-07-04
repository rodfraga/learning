public class ValidParentheses {
    public bool IsValid(string s) {
        // corner case
            if (string.IsNullOrEmpty(s))
               return true;
            // arrange
            var elements = new Stack<char>();
            // compute
            foreach (var item in s)
            {
                switch(item)
                {
                    case '(':
                    case '[':
                    case '{':
                        elements.Push(item);
                        break;

                    case ')':
                    case ']':
                    case '}':
                        // your stuf here

                        // if empty starting with closure
                        if (elements.Count <= 0) return false;

                        char prev = elements.Pop();
                        // check validity
                        if ((prev == '(' && item == ')') ||
                            (prev == '[' && item == ']') ||
                            (prev == '{' && item == '}'))
                            continue;

                        return false;
                }

            }

            // a valid input must be empty
            return elements.Count == 0;
    }
}
