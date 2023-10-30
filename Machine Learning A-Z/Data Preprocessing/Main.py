# Sami Munir
# Machine Learning A-Z
# Data Preprocessing
# Main.py

print('\nData Preprocessing')

# Importing the libraries
import pandas as pd
# from sklearn.impute import SimpleImputer
# import numpy as np
# from sklearn.compose import ColumnTransformer
# from sklearn.preprocessing import OneHotEncoder
# from sklearn.preprocessing import LabelEncoder
# from sklearn.model_selection import train_test_split

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

# Encoding categorical data
from sklearn.compose import ColumnTransformer
from sklearn.preprocessing import OneHotEncoder
# - Encoding the independent variable
ct = ColumnTransformer(transformers=[('encoder', OneHotEncoder(), [0])], remainder='passthrough')
X = np.array(ct.fit_transform(X))
print('\nX -->\n', X)
# - Encoding the dependent variable vector
from sklearn.preprocessing import LabelEncoder
le = LabelEncoder()
y = le.fit_transform(y)
print('\ny -->\n', y)

# Splitting the data set into the Training set & Test set
from sklearn.model_selection import train_test_split
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=1)
print('\nX_train -->\n', X_train)
print('\nX_test -->\n', X_test)
print('\ny_train -->\n', y_train)
print('\ny_test -->\n', y_test)