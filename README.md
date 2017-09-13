# encryption

this method is for hashing texts may be you can use for hashing password or genrate tokens by the way you it becomes so difecult to detect the origanl string

first we are convert the string to byte array and implement astringbuilder so that generating our strings using it to write our strings

first thing is to add all bytes besides each other so that you cant know which number have to select with other

Suppose you have these three bytes
[128,15,200]
the first foreach make them like that
12815200 now its hard to know which  mix of digits can be the right byte but its not impossible
now we assign text to the ne string and clear builder

now we will do some thing hard for any to decode  my be impossible but i think this word is not in the programming dctionary

if you not heard before about the math magic square you can google it now that algorithm not uses it but its anti magic square
immagine you have asquare  that consists of 9 squares 3*3 every one contains number
our loop is sum every xline and every yline and create new string with this sums
then add The remaining numbers at the ending

last thing is to decorate your hash by one of Cryptographic hash functions
you may use md5 if you want short hash
