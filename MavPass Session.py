2/21/23
#How to find a sum and average in a list
#The Below utilizes the sum function so you can't use the sum variable
"""
a= [1,2,3,4]
b = sum(a)
c = b/len(a)
print("Sum",b)
print("Average",c)
"""
#Below is incomplete
"""
sum = 0
a=[1,2,3]
for i in a:
    sum+=i
    return a
"""
#Write a program(not a function) to print a dictionary where the keys are numbers between 1 and 10 (both included) and the values are the square of the keys.
d=dict()
for x in range(1,11):
    d[x]=x**2
print(d)
