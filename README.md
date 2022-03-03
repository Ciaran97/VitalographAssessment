# Vitalograph

Changes made to the code base.

1. A check is made before the loop is entered to determine if the input string contains invalid characters or is null using Regex.
2. The logic to shift characters is moved into a separate method. (This could be used multiple times in a larger application.)
3. A StringBuilder is used as this tends to be faster than regular string concatenation.
4. Using the remainder operator (%) to ensure the characters returned are between A-Z as well as creating a simple algorithm.
5. Add error handling to prevent the application from terminating on exception.
