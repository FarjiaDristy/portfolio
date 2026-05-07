'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

function reverseString(s) {
    try {
        // Reverse the string
        let reversed = s.split('').reverse().join('');
        console.log(reversed);
    } 
    catch (error) {
        // Print error message
        console.log(error.message);
        
        // Print original input
        console.log(s);
    }
}


function main() {
    const s = eval(readLine());
    
    reverseString(s);
}
