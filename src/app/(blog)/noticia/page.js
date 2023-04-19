'use server'

export async function generateMetadata({ params }) {
    return {
      title: 'Cadastro de notícia'
    };
  }

export default async function Page(){
    return(
        <>
            <h2>Cadastro de notícia</h2>
        </>
    )
}