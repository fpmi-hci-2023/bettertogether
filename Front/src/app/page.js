async function getData() {

  try{
    const res = await fetch('http://backenddemo:80/hello-world')
    if (!res.ok) {
      throw new Error('Failed to fetch data')
    }

    return res.text()
  }
  catch(er)
  {
    console.log(er)
  }
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