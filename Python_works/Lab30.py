# matplotlib inline
import pandas as pd
import matplotlib.pyplot as plt
plt.style.use('ggplot') # Красивые графики
plt.rcParams['figure.figsize'] = (15, 5) # Размер картинок

fixed_df = pd.read_csv('C:/Users/dorak/Documents/GitHub/MyLabs/Python_works/Monreal.csv', # Это то, куда вы скачали файл
sep=';', encoding='latin1',
parse_dates=['Date'], dayfirst=True,
index_col='Date')
fixed_df[:3]
