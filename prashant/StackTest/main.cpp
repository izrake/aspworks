#include <iostream>

using namespace std;

struct node{
int data;
node *link;
};
class stack{
private:
    struct node *top;
public:
    stack();
    void push(int n);
    void pop();
    void display();


};
stack::stack(){
top=NULL;
}
void stack::push(int n)
{
    node *temp;
    temp=new node;
    if(temp==NULL){
    cout<<"the stack is under flow";
    }
    else{
        temp->data=n;
        temp->link=top;
        top=temp;
    }
}

void stack::pop(){
if(top==NULL){
    cout<<"the stack is underflow";
}
else{
    node *temp;
    int n;
    temp=top;
    n=temp->data;
    cout<<"the popped values is: "<<n;
    top=top->link;
    delete temp;

}

}

void stack::display(){
node *temp;
temp=top;
if(temp==NULL){
    cout<<"\n the stack is empty";
}
else{
    cout<<"the value of the stack is as: \n";
    while(temp!=NULL){
        cout<<temp->data<<"\n";
        temp=temp->link;
    }
}
}


int main()
{
    stack s;
    int x,ch;
    do
    {
        cout<<"\n1.Push";
        cout<<"\n2.Pop";
        cout<<"\n3.Display";
        cout<<"\n4.Exit";
        cout<<"\nEnter the choice";
        cin>>ch;
        switch(ch)
        {
        case 1:
            cout<<"\nEnter the element to be pushed";
            cin>>x;
            s.push(x);
            cout<<"\nThe element is inserted";
            break;
        case 2:
            s.pop();
            break;
        case 3:
            s.display();
        case 4:
            break;
        }
    }
    while(ch!=4);
    return 0;
}
