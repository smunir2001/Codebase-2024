# Sami Munir
# Machine Learning A-Z
# Data Preprocessing
# Main.py

print('\nData Preprocessing')

# Importing the libraries
import pandas as pd
# from sklearn.impute import SimpleImputer
# import numpy as np

# Importing the dataset
dataset = pd.read_csv('./data/Data.csv')
print('\n./data/Data.csv')
print('dataset -->\n', dataset)
X = dataset.iloc[:, :-1].values # all columns & rows for features.
y = dataset.iloc[:, -1].values # last column & all rows for independent variable vector
print('\nX -->\n', X)
print('\ny -->\n', y)

# Taking care of missing data
from sklearn.impute import SimpleImputer
import numpy as np
print('\nX -->\n', X)
imputer = SimpleImputer(missing_values=np.nan, strategy='mean')
imputer.fit(X[:, 1:3]) # capture all numerical valued columns (exclude any text valued columns)
X[:, 1:3] = imputer.transform(X[:, 1:3]) # updating the numerical valued columns in matrix of features X
print('\nupdated X -->\n', X)