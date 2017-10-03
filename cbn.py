import sys

# Author: Po-Chun Chiu
# Partner: Yujie Liu
# CSC254 A1 Python Combination

# sys package helps to take argv[] input for k and n

# In python, Indentation matters!
# a method in which returns a list of possible remaining selection that can be chosen
def left(prev, index, k, n):
    l= list()
    # for loop in python is left inclusive and right not inclusive
    for i in range(prev+1, n-(k-index)+1):
        l.append(i)
    return l

# main cb function to print out possible combinations
def cb(array, current, k,n):
    # the function takes an array, an integer index named current, integer k and n
    # Print the possible combinations once the current index is k
    if current == k:
        for m in range(k):
            if m == (k-1):
                print(array[m])
            else:
                print(array[m], end = " ")
    else:
        #Initialize a list called remain
        remain = list()
        if current == 0:
            for i in range(1, n+1):
                remain.append(i)
        else:
            # remain will try to find the left possible choices using left function
            remain=left(array[current-1],current+1,k,n)
        for j in range(len(remain)):
            array[current]=remain[j]
            cb(array, current+1, k, n)

def main():
    # k takes argv[1] and n takes argv[2]
    k = int(sys.argv[1])
    n = int(sys.argv[2])
    l=[None]*k
    # initialize an k size array filling with None 
    cb(l,0,k,n)

# called main function itself
if __name__ == '__main__':
    main()

