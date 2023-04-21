'use server'

export async function generateMetadata({ params }) {
    return {
        title: 'Cadastro de Leitor'
    };
}

export default async function Page() {
    return (
        <>
            <h2>Cadastro de Leitor</h2>
        </>
    )
}