import random
champ=[]
for x in range(999999):
    k=input("Enter a Champion or leave blank to complete:")
    champ.append(k)
    if k=="":
        break
lit=random.sample(champ,1)
print(lit)