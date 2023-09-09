import pandas as pd

df = pd.read_csv('sample_data/california_housing_train.csv')
data = pd.read_csv(df)

filtered_data = data[(data['population'] >= 0) & (data['population'] <= 500)]
average_house_value = filtered_data['median_house_value'].mean()
print("Средняя стоимость дома с количеством людей от 0 до 500:", average_house_value)
