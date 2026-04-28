#cpp 11 14 20
#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <regex>

using namespace std;

int main() {
    int N;
    cin >> N;
    
    vector<string> gmailUsers;
    regex pattern(".+@gmail\\.com$");
    
    for(int i = 0; i < N; i++) {
        string firstName, emailID;
        cin >> firstName >> emailID;
        
        if (regex_match(emailID, pattern)) {
            gmailUsers.push_back(firstName);
        }
    }
    
    sort(gmailUsers.begin(), gmailUsers.end());
    
    for (const auto& name : gmailUsers) {
        cout << name << endl;
    }
    
    return 0;
}
