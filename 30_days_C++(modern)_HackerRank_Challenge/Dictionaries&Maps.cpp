#c++11/14/20
#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <map>
#include <unordered_map>
using namespace std;



int main() {
     int n;
    cin >> n;

    unordered_map<string, string> phonebook;

    for (int i = 0; i < n; i++) {
        string name, number;
        cin >> name >> number;
        phonebook[name] = number;
    }

    string query;
    while (cin >> query) {
        if (phonebook.find(query) != phonebook.end())
            cout << query << "=" << phonebook[query] << endl;
        else
            cout << "Not found" << endl;
    }

  
    return 0;
}
