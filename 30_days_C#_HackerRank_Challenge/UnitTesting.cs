#...
class TestDataEmptyArray {
    public static int[] get_array() {
        return new int[0];
    }
}

class TestDataUniqueValues {
    public static int[] get_array() {
        return new int[] { 10, 5, 20 };
    }
    public static int get_expected_result() {
        return 1; // Index of '5'
    }
}

class TestDataExactlyTwoDifferentMinimums {
    public static int[] get_array() {
        return new int[] { 3, 1, 4, 1 };
    }
    public static int get_expected_result() {
        return 1; // Smallest index of '1'
    }
}
#...
