# Sami Munir
# Machine Learning A-Z
# Data Preprocessing
# Main.py

print('\nData Preprocessing')

# Importing the libraries
import pandas as pd

# Importing the dataset
dataset = pd.read_csv('./data/Data.csv')
print('\n./data/Data.csv')
print('dataset -->\n', dataset)
X = dataset.iloc[:, :-1].values # all columns & rows for features.
y = dataset.iloc[:, -1].values # last column & all rows for independent variable vector
print('\nX -->\n', X)
print('\ny -->\n', y)
