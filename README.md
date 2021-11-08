# Projeto Parcial 3 - Computação Gráfica
Prof. Dr. Mario Liziér & Prof. Dr. Siovani Felipussi

## Integrantes
Jesimiel Efraim Dias,
Lucas Henrique de Araújo,
Rafael Pincinato Toledo,
Victor Mendes,
Victória Resende.

## Instruções de uso
Utilizamos o Unity na versão 2020.3.21f1 (64-bit), uma plataforma de desenvolvimento 3D, bastante usada na criação de jogos.
Para facilitar a visualização, foi disponibilizado um executável de nome *My Project*, que é o projeto previamente buildado. O campo de visão se ajusta para a resolução do monitor que está sendo exibido, por isso é recomendado um monitor com a resolução 16:9.

## Ambientação
Foram adicionados um chão com textura de grama para se ter uma maior percepção do espaço em que os objetos se encontram, uma câmera para a visualização dos objetos e uma luz para auxiliar na percepção de profundidade.

##  Objetos 3D
Os objetos adicionados foram um cilindro, uma composição de cubos, uma árvore, um relógio e uma engrenagem. Após isso, redimensionamos e posicionamos individualmente cada um dos objetos na cena em frente à câmera com um espaçamento entre eles.
**Conceitos mapeados por objeto:**
Para não ficar muito grande será omitido as escalas que tiverem os valores padrões que para a escala é X: 1, Y: 1 e Z: 1, para a rotação é X: 0, Y: 0 e Z: 0.
*Cilindro:*
Posição
X:-15, Y:5, Z:3

*Cubos:*
Posição
X:-5, Y:5, Z:3

*Árvore:*
Posição
X:15, Y:0, Z:3

*Relógio:*
Posição
X:25, Y:5, Z:3
Rotação
X:0, Y:270, Z:0
Escala
X:3, Y:3, Z:3

*Engrenagem:*
Posição
X:5, Y:5, Z:3
Rotação
X:270, Y:0, Z:0

## Scripts
Nos objetos *Cilindro* e *Cubos* foram adicionados scripts para praticar os conceitos vistos em aula e como o Unity os implementa.
Os conceitos aplicados foram: *redimensionamento*, *transposição* e *rotação*.
Em ambos os scripts, o intervalo no qual os objetos fazem a *transposição* é *[3, 25]*, sendo que inicialmente, é feito *redimensionamento* e uma *rotação* sempre que são atingidos os limites do intervalo.