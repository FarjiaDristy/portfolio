#CPP 11 14 20
#include <iostream>
#include <string>
#include <vector>

using namespace std;

class Book {
    protected:
        string title;
        string author;
    public:
        Book(string t, string a) {
            title = t;
            author = a;
        }
        virtual void display() = 0;
};


class MyBook : public Book {
    private:
        int price;
    
    public:
        /** * Class Constructor
        * * Parameters:
        * title - The book's title.
        * author - The book's author.
        * price - The book's price.
        **/
        MyBook(string title, string author, int price) 
            : Book(title, author), price(price) {

        }
        

        void display() override {
            cout << "Title: " << title << endl;
            cout << "Author: " << author << endl;
            cout << "Price: " << price << endl;
        }
};


int main() {
    string title, author;
    int price;
    getline(cin, title);
    getline(cin, author);
    cin >> price;
    MyBook novel(title, author, price);
    novel.display();
    return 0;
}
