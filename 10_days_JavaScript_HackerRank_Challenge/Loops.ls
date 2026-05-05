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

function vowelsAndConsonants(s) {

    const vowels = 'aeiou';
    
    // First pass: vowels
    for (let char of s) {
        if (vowels.includes(char)) {
            console.log(char);
        }
    }
    
    // Second pass: consonants
    for (let char of s) {
        if (!vowels.includes(char)) {
            console.log(char);
        }
    }
}
function main() {
    const s = readLine();
    
    vowelsAndConsonants(s);
}
