public Difference(int[] elements)
    {
        this.elements = elements;
    }

    public void computeDifference()
    {
        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (int x in elements)
        {
            if (x < min) min = x;
            if (x > max) max = x;
        }

        maximumDifference = max - min;
    }
}
