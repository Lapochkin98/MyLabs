import pandas as pd
import numpy as np

print("Series: ")
MySeries = pd.Series(np.random.rand(8),
index=[['white','white','white','blue','blue','red','red', 'red'],
['up','down','right','up','down','up','down','left']])
print(MySeries)
print(MySeries.index)
print(MySeries.unstack())

print("DataFrame: ")
MyDataFrame = pd.DataFrame(np.random.randn(16).reshape(4,4),
index=[['white','white','red','red'], ['up','down','up','down']],
columns=[['pen','pen','paper','paper'],[1,2,1,2]])
print(MyDataFrame)

print(print(MyDataFrame.stack()))
MyDataFrame.columns.names = ['objects','id']
MyDataFrame.index.names = ['colors','status']
print(MyDataFrame)
print(MyDataFrame.swaplevel('colors','status'))
print(MyDataFrame.sort_index(level='colors'))