#CPP 11 14 20
#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

class Difference {
    private:
    vector<int> elements;
  
      public:
      int maximumDifference;

    Difference(vector<int> el) : elements(el) {}

    void computeDifference() {
        int min_val = 101; 
        int max_val = 0;   
        
        for (int val : elements) {
            if (val < min_val) min_val = val;
            if (val > max_val) max_val = val;
        }
        
        maximumDifference = max_val - min_val;
    }

}; 

int main() {
    int N;
    cin >> N;

    vector<int> a;

    for (int i = 0; i < N; i++) {
        int e;
        cin >> e;

        a.push_back(e);
    }

    Difference d(a);

    d.computeDifference();

    cout << d.maximumDifference;

    return 0;
}
