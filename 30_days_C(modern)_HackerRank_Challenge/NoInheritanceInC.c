int calculate(int scores[], int n) {
    int sum = 0;
    for (int i = 0; i < n; i++)
        sum += scores[i];

    int avg = sum / n;

    if (avg >= 90) return 'O';
    if (avg >= 80) return 'E';
    if (avg >= 70) return 'A';
    if (avg >= 55) return 'P';
    if (avg >= 40) return 'D';
    return 'T';
}
