int[] codes = new[] { 1, 12, 2, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 10, 19, 2, 9, 19, 23, 1, 9, 23, 27, 2, 27, 9, 31, 1, 31, 5, 35, 2, 35, 9, 39, 1, 39, 10, 43, 2, 43, 13, 47, 1, 47, 6, 51, 2, 51, 10, 55, 1, 9, 55, 59, 2, 6, 59, 63, 1, 63, 6, 67, 1, 67, 10, 71, 1, 71, 10, 75, 2, 9, 75, 79, 1, 5, 79, 83, 2, 9, 83, 87, 1, 87, 9, 91, 2, 91, 13, 95, 1, 95, 9, 99, 1, 99, 6, 103, 2, 103, 6, 107, 1, 107, 5, 111, 1, 13, 111, 115, 2, 115, 6, 119, 1, 119, 5, 123, 1, 2, 123, 127, 1, 6, 127, 0, 99, 2, 14, 0, 0 };

int[] Part1(int[] args)
{
    for(int i = 0; i < args.Length; i += 4)
    {
        int op = args[i];

        if (op == 1)
        {
            args[args[i + 3]] = args[args[i + 1]] + args[args[i + 2]];
        }
        else if (op == 2)
        {
            args[args[i + 3]] = args[args[i + 1]] * args[args[i + 2]];
        }
        else if (op == 99)
        {
            break;
        }
    }

    return args;
}

(int Noun, int Verb) Part2(int[] args)
{
    (int noun, int verb) = (0,0);

    for(int i = 0; i < 99; ++i)
    {
        for (int i2 = 0; i2 < 99; ++i2)
        {
            int[] clone = (int[])args.Clone();
            args[1] = i;
            args[2] = i2;

            int result = Part1(clone)[0];

            if (result == 19690720)
            {
                (noun, verb) = (clone[1], clone[2]); 
                break;
            }
        }
    }

    return (noun, verb);
}

Console.WriteLine("Part 1: {0}", Part1((int[])codes.Clone())[0]);
Console.WriteLine("Part 2: {0}", Part2((int[])codes.Clone()));