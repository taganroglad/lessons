import org.apache.spark.sql.{SparkSession, Row}
import org.apache.spark.sql.types._

object CreateDataFrameExample {
  def main(args: Array[String]): Unit = {
    val spark = SparkSession.builder()
      .appName("CreateDataFrameExample")
      .getOrCreate()

    // Создаем список данных для каждого столбца
    val data = Seq(
      Row("E801", "Alice", "J01", "Chef", 26, "Moscow"),
      Row("E801", "Alice", "J02", "Waiter", 26, "Moscow"),
      Row("E802", "Bob", "J02", "Waiter", 56, "Perm"),
      Row("E802", "Bob", "J03", "Bartender", 56, "Perm"),
      Row("E803", "Alice", "J01", "Cheif", 56, "Perm")
    )

    // Определяем схему таблицы
    val schema = StructType(Seq(
      StructField("Employee_ID", StringType, nullable = false),
      StructField("Name", StringType, nullable = false),
      StructField("Job_code", StringType, nullable = false),
      StructField("Job", StringType, nullable = false),
      StructField("City_code", IntegerType, nullable = false),
      StructField("Home_city", StringType, nullable = false)
    ))

    // Создаем DataFrame
    val df = spark.createDataFrame(
      spark.sparkContext.parallelize(data),
      schema
    )

    // Выводим содержимое DataFrame на экран
    df.show()
  }
}