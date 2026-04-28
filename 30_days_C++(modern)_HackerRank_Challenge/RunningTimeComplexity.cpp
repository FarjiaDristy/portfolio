#cpp 11 14 20
#include <iostream>
#include <cmath>

using namespace std;

void checkPrimality() {
    int n;
    cin >> n;
    
    if (n <= 1) {
        cout << "Not prime" << endl;
        return;
    }
    if (n == 2) {
        cout << "Prime" << endl;
        return;
    }
    if (n % 2 == 0) {
        cout << "Not prime" << endl;
        return;
    }

    bool isPrime = true;
    for (int i = 3; i * i <= n; i += 2) {
        if (n % i == 0) {
            isPrime = false;
            break;
        }
    }

    if (isPrime) cout << "Prime" << endl;
    else cout << "Not prime" << endl;
}

int main() {
    int t;
    cin >> t;
    while (t--) {
        checkPrimality();
    }
    return 0;
}
