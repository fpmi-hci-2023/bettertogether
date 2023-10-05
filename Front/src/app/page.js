async function getData() {
  const res = await fetch('https://jsonplaceholder.typicode.com/posts') //поменяй адрес на нужный
  if (!res.ok) {
    throw new Error('Failed to fetch data')
  }
  return res.text()
}

export default async function Home() {

  const data = await getData()

  return (
    <>
      {data}
    </>
  )
}

//npm i
//npm run dev
//localhost:3000


//ctrl + c  --------завершить