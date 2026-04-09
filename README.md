AI prac




1. Medical Diagnosis


symptoms = input("Enter symptoms(fever, headache, cough): ")

rules = {
    ("fever", "cough"): "Flu",
    ("fever", "headache"): "Dengue",
    ("cough"): "Cold"

}

for rule in rules:
   if all(s in symptoms for s in rules):
       print("Possible Disease:", rules[rule])
       break
else:
   print("Consult doctor")






2. Hill Climbing for e-commerce inventory


inventory = {
    "A": 40,
    "B": 55,
    "C": 65,
    "D": 60,
    "E": 50
}

locations = list(inventory.keys())

def hill_climb(start):
    current = start

    while True:
        idx = locations.index(current)
        neighbors = []

        if idx > 0:
            neighbors.append(locations[idx-1])
        if idx < len(locations)-1:
            neighbors.append(locations[idx+1])

        best = current
        for n in neighbors:
            if inventory[n] > inventory[best]:
                best = n

        if best == current:
            return current

        current = best

result = hill_climb("A")

print("Optimal location:", result)
print("Inventory:", inventory[result])







3. Constraint Satisfaction Scheduling


doctors = ["DrA", "DrB", "DrC"]
shifts = ["Morning", "Evening", "Night"]

schedule = {}

def is_valid(doc, assigned):
    return doc not in assigned.values()

def assign_shift(i):
    if i == len(shifts):
        return True

    for doc in doctors:
        if is_valid(doc, schedule):
            schedule[shifts[i]] = doc
            if assign_shift(i + 1):
                return True
            del schedule[shifts[i]]

    return False

assign_shift(0)

print("Shift Schedule:")
for s in schedule:
    print(s, "->", schedule[s])







4. Learning Recommendation System


courses = {
    "Python": 5,
    "MachineLearning": 4,
    "WebDevelopment": 3,
    "DataScience": 5,
    "CyberSecurity": 4
}

goal = "HighSkill"

def recommend(data):
    best = None
    best_score = -1

    for course, score in data.items():
        if score > best_score:
            best_score = score
            best = course

    return best

result = recommend(courses)

print("Recommended Course:", result)
print("Skill Score:", courses[result])








5. A* Resource Allocation


import heapq

graph = {
    'Warehouse': {'Hub1':2,'Hub2':4},
    'Hub1': {'Store':5},
    'Hub2': {'Store':2},
    'Store': {}
}

heuristic = {'Warehouse':7,'Hub1':4,'Hub2':2,'Store':0}

def astar(start, goal):
    pq = [(0,start)]
    visited = set()

    while pq:
        cost,node = heapq.heappop(pq)

        if node == goal:
            print("Reached:", node)
            return

        if node not in visited:
            visited.add(node)
            for n,w in graph[node].items():
                f = cost + w + heuristic[n]
                heapq.heappush(pq,(f,n))

astar('Warehouse','Store')








6. Fuzzy Logic Stock Prediction



def predict(price_change, volume):

    if price_change > 2 and volume > 1000:
        trend = "Strong Bullish"
    elif price_change > 0:
        trend = "Bullish"
    elif price_change < -2 and volume > 1000:
        trend = "Strong Bearish"
    elif price_change < 0:
        trend = "Bearish"
    else:
        trend = "Stable"

    return trend

price = float(input("Price change (%): "))
volume = int(input("Trading volume: "))

result = predict(price, volume)

print("Market Trend:", result)






8. Predicate Logic (Family Relationship)



father = {
    "Ram":"Shyam",
    "Shyam":"Amit",
    "Amit":"Rohan"
}

for f in father:
    print(f,"is father of",father[f])

def grandfather(x,z):
    if father.get(x) and father.get(father[x]) == z:
        return True

print("Ram grandfather of Amit:", grandfather("Ram","Amit"))





9. Tic-Tac-Toe Game


board=[" "]*9

def show():
    print(board[0:3])
    print(board[3:6])
    print(board[6:9])

for turn in range(5):
    show()
    p1=int(input("Player X move: "))
    board[p1]="X"

    show()
    p2=int(input("Player O move: "))
    board[p2]="O"

show()






10. Spell Checker (NLP)


dictionary = ["python","artificial","intelligence","algorithm"]

word=input("Enter word: ").lower()

if word in dictionary:
    print("Correct spelling")
else:
    for w in dictionary:
        if w.startswith(word[0]):
            print("Did you mean:",w)





11. Neural Network Pattern Recognition


inputs=[1,2,3]
weights=[0.3,0.5,0.2]

bias=0.1

output=0

for i in range(len(inputs)):
    output += inputs[i]*weights[i]

output += bias

print("Neuron output:",output)