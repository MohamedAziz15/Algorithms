# from pythonds.graphs import PriorityQueue, Graph, Vertex
from queue import *
from Graph import *

g = graph({"A": ["B", "C", "E", "D"],
           "B": ["A", "D", "F"],
           "C": ["A", "E"],
           "D": ["A", "B", "E", "F"],
           "E": ["A", "C", "D", "F"],
           'F': ["B", "D", "E"]})

print(g.getVertices())
q = Queue()
q = g.getVertices()

# define root
r = "A"

# k is the values of vertex
k = dict()

# P is the parent of vertix
p = dict()

for u in q:
    k[u] = 99

k[r] = 0
p[r] = None

cost = dict()
for u in q:
    s = k[u]
    cost[u] = s

# each vertix with its wieght
print("cost")
print(cost)

# method for extract minimum wieght vertix from graph
def extract_minimum():
    min=50
    vert=""
    for v in cost:
        if min > cost[v]:
            min = cost[v]
            vert=v
    return vert 

#method for adjacent nodes for specific node
def adjacent(v):
    adjacent_list = []
    adjacent_list = g.gdict.get(v) 
    return adjacent_list

#method for assign cost for edge
wieght = dict()
def wieghts():
    all_edges=[]
    all_edges = g.findedges()
    # wieght = dict()
    for i in range(10):
        for u in all_edges:
            #wieght[u] = all_edges[i]
            ss=all_edges[i]
            wieght[i] = ss
            #print( wieght)
    return wieght        

print("weights is :")
w =dict()
w=wieghts()
print(w)
#print(wieghts())           

            


print("minimum")
mini = extract_minimum()
print(mini)

print("adjacent")
print(adjacent("B"))
#print(g.gdict.get("A"))


print("find edges: ")
print(g.findedges())


all_edges=[]
all_edges = g.findedges()
print("find edges: ")
print(all_edges)



def get_key(u,v):
    key_list = list(w.keys())
    val_list = list(w.values())
    # print key with val 100
    position = val_list.index({v, u})
    print("key")
    print(key_list[position])

sorted=[]

while q!= None:
    u = extract_minimum()
    for v in adjacent(u):
        if q.__contains__(v) :
            skl=0
            wi = get_key(u,v) 
            skl = wi 
            if skl < cost[v]: 
                p[u] = v
                k[v] = w(u,v)
        sorted.append(q.pop(u))

print("Sorted Graph " + sorted)


#     # u= Extract-min(Q)
#     for v in adj[u]:
#         if q.__contains__(v) and w(u, v) < k[v]:
#             p[v] = u
#             k[v] = w(u, v)