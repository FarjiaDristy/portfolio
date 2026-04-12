#python-2
class Difference:
    def __init__(self, a):
        self.__elements = a

        self.__elements = a
        self.maximumDifference = 0

    def computeDifference(self):
        self.maximumDifference = max(self.__elements) - min(self.__elements)

# End of Difference class

_ = raw_input()
a = [int(e) for e in raw_input().split(' ')]

d = Difference(a)
d.computeDifference()

print d.maximumDifference

#Python-3
class Difference:
    def __init__(self, a):
        self.__elements = a

        self.maximumDifference = 0

    def computeDifference(self):
        self.maximumDifference = max(self.__elements) - min(self.__elements)

# End of Difference class

_ = input()
a = [int(e) for e in input().split(' ')]

d = Difference(a)
d.computeDifference()

print(d.maximumDifference)
