int[] nbrs = { 7, 11, 42, 99, 32, -14, 1, 72, -54, - 45};

var sum = 0;
var index = 0;

while (index < 10)
    {
    sum = sum / nbrs[index];
    index = index + 1;
    }


Console.WriteLine($"The sum is {sum / 10}");
