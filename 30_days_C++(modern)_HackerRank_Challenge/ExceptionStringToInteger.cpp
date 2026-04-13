#CPP 11 14 20
#include <bits/stdc++.h>

using namespace std;

int main()
{
    string S;
    getline(cin, S);
    cin >> S;

    try {
        int num = stoi(S);
        cout << num;
    }
    catch (...) {
        cout << "Bad String";
    }

    return 0;
}
