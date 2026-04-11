#C++11 / 14 / 20
#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main() {
    int T;
    cin >> T;

    while (T--) {
        string s;
        cin >> s;

        string even = "", odd = "";

        for (int i = 0; i < s.length(); i++) {
            if (i % 2 == 0)
                even += s[i];
            else
                odd += s[i];
        }

        cout << even << " " << odd << endl;
    } 
    return 0;
}
